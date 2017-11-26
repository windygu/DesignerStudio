﻿// Copyright (c) 2014 AlphaSierraPapa for the SharpDevelop Team
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
// to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

using AvalonDock;
using ICSharpCode.Core.Presentation;
using ICSharpCode.SharpDevelop.Gui;
using ICSharpCode.SharpDevelop.Services.Commands;
using MahApps.Metro.IconPacks;
//using ICSharpCode.SharpDevelop.Gui;

namespace ICSharpCode.SharpDevelop.Workbench
{
	public sealed class AvalonPadContent : DockableContent, IDisposable
	{
		PadDescriptor descriptor;
		IPadContent padInstance;
		AvalonDockLayout layout;
		TextBlock placeholder;			
		
		public static DependencyProperty HasIconProperty =
			DependencyProperty.Register("HasIcon", typeof(bool), typeof(AvalonPadContent));
		
		public bool HasIcon{
			get { return (bool)GetValue(HasIconProperty); }
			set { SetValue(HasIconProperty, value); }
		}		

		public static DependencyProperty HasPackIconProperty =
			DependencyProperty.Register("HasPackIcon", typeof(bool), typeof(AvalonPadContent));
		
		public bool HasPackIcon{
			get { return (bool)GetValue(HasIconProperty); }
			set { SetValue(HasIconProperty, value); }
		}
		
		public IPadContent PadContent {
			get { return padInstance; }
		}		

		public static DependencyProperty PackIconKindProperty =
			DependencyProperty.Register("PackIconKind", typeof(PackIconMaterialKind), typeof(AvalonPadContent));
		
		public Enum PackIconKind{
			get { return (Enum)GetValue(PackIconKindProperty); }
			set { SetValue(PackIconKindProperty, value); }
		}
		
		public AvalonPadContent(AvalonDockLayout layout, PadDescriptor descriptor)
		{
			this.descriptor = descriptor;
			this.layout = layout; 
						
			CustomFocusManager.SetRememberFocusedChild(this, true);
			this.Name = descriptor.Class.Replace('.', '_');
			this.SetValueToExtension(TitleProperty, new StringParseExtension(descriptor.Title));
			placeholder = new TextBlock { Text = this.Title };
			this.Content = placeholder;
			
			if (String.IsNullOrEmpty(descriptor.PackIconKey)) {
				if (!String.IsNullOrEmpty(descriptor.Icon)) {
					this.Icon = PresentationResourceService.GetBitmapSource(descriptor.Icon);
					HasIcon = true;
				}
			} else {
				if (descriptor.PackIconKey.Contains(";")) {
					string[] packIconValues = descriptor.PackIconKey.Split(';');
					string packIconType = packIconValues[0];
					string packIconKind = packIconValues[1];
					
					switch (packIconType) {
						case "PackIconMaterial":
							PackIconKind =	(Enum)Enum.Parse(typeof(PackIconMaterialKind), 
								packIconKind);
							break;
						case "PackIconMaterialLight":
							PackIconKind = (Enum)Enum.Parse(typeof(PackIconMaterialLightKind),
								packIconKind);
							break;
						case "PackIconModern":
							PackIconKind = (Enum)Enum.Parse(typeof(PackIconModernKind),
								packIconKind);
							break;
						case "PackIconOcticons":
							PackIconKind = (Enum)Enum.Parse(typeof(PackIconOcticonsKind),
								packIconKind);
							break;
						case "PackIconSimpleIcons":
							PackIconKind = (Enum)Enum.Parse(typeof(PackIconSimpleIconsKind),
								packIconKind);
							break;
						case "PackIconEntypo":
							PackIconKind = (Enum)Enum.Parse(typeof(PackIconEntypoKind),
								packIconKind);
							break;
						case "PackIconFontAwesome":
							PackIconKind = (Enum)Enum.Parse(typeof(PackIconFontAwesomeKind),
								packIconKind);
							break;
					}
					HasPackIcon = true;
				}
			}
			
			placeholder.IsVisibleChanged += AvalonPadContent_IsVisibleChanged;
		}
		
		protected override void FocusContent()
		{
			if (!(IsActiveContent && !IsKeyboardFocusWithin))
				return;
			IInputElement activeChild = CustomFocusManager.GetFocusedChild(this);
			AvalonWorkbenchWindow.SetFocus(this, () => activeChild ?? (padInstance != null ? padInstance.InitiallyFocusedControl as IInputElement : null));
		}
		
		public void ShowInDefaultPosition()
		{
			AnchorStyle style;
			if ((descriptor.DefaultPosition & DefaultPadPositions.Top) != 0)
				style = AnchorStyle.Top;
			else if ((descriptor.DefaultPosition & DefaultPadPositions.Left) != 0)
				style = AnchorStyle.Left;
			else if ((descriptor.DefaultPosition & DefaultPadPositions.Bottom) != 0)
				style = AnchorStyle.Bottom;
			else
				style = AnchorStyle.Right;
			
			this.Show(layout.DockingManager, style);
			if ((descriptor.DefaultPosition & DefaultPadPositions.Hidden) != 0)
				Hide();
		}
		
		void AvalonPadContent_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(LoadPadContentIfRequired));
		}
		
		internal void LoadPadContentIfRequired()
		{
			bool dockingManagerIsInitializing = layout.Busy || !layout.DockingManager.IsLoaded;
			if (placeholder != null && placeholder.IsVisible && !dockingManagerIsInitializing) {
				placeholder.IsVisibleChanged -= AvalonPadContent_IsVisibleChanged;
				padInstance = descriptor.PadContent;
				if (padInstance != null) {
					bool isFocused = this.IsKeyboardFocused;
					SD.WinForms.SetContent(this, padInstance.Control, padInstance);
					placeholder = null;
					
					if (isFocused) {
						IInputElement initialFocus = padInstance.InitiallyFocusedControl as IInputElement;
						if (initialFocus != null) {
							Dispatcher.BeginInvoke(DispatcherPriority.Loaded,
							                       new Action(delegate { Keyboard.Focus(initialFocus); }));
						}
					}
				}
			}
		}

		public void Dispose()
		{
			if (padInstance != null) {
				padInstance.Dispose();
			}
		}
		
		public override string ToString()
		{
			return "[AvalonPadContent " + this.Name + "]";
		}
	}
}
