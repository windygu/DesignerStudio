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
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using MahApps.Metro.IconPacks;

namespace ICSharpCode.Core.Presentation
{
	/// <summary>
	/// A menu item representing an AddIn-Tree element.
	/// </summary>
	public class CoreMenuItem : MenuItem, IStatusUpdate
	{
		protected readonly Codon codon;
		protected readonly object caller;
		protected readonly IReadOnlyCollection<ICondition> conditions;
		
		/// <summary>
		/// If true, UpdateStatus() sets the enabled flag.
		/// Used for type=Menu, but not for type=MenuItem - for menu items, Enabled is controlled by the WPF ICommand.
		/// </summary>
		internal bool SetEnabled;
		
		public CoreMenuItem(Codon codon, object caller, IReadOnlyCollection<ICondition> conditions)
		{
			this.codon = codon;
			this.caller = caller;
			this.conditions = conditions;
					
			if (codon.Properties.Contains("template")) {
					this.Template = Application.Current.FindResource("MenuItemTemplateKey") as ControlTemplate;
					this.ApplyTemplate();
			} else {
				if (codon.Properties.Contains("packIconKey")) {
					string[] packIconValues = codon.Properties["packIconKey"].Split(';');
					string packIconType = packIconValues[0];
					string packIconKind = packIconValues[1];
				//object icon = null;
					
					switch(packIconType){
						case "PackIconMaterial":
							var icon = new PackIconMaterial();
							((PackIconMaterial)icon).Kind = (PackIconMaterialKind)Enum
															.Parse(typeof(PackIconMaterialKind),
														       packIconKind);
								this.Icon = icon;
							break;
						case "PackIconMaterialLight":
						var icon1 = new PackIconMaterialLight();
							((PackIconMaterialLight)icon1).Kind = (PackIconMaterialLightKind)Enum
															.Parse(typeof(PackIconMaterialLightKind),
														       packIconKind);
							this.Icon = icon1;
							break;
						case "PackIconModern":
							var icon2 = new PackIconModern();
							((PackIconModern)icon2).Kind = (PackIconModernKind)Enum
															.Parse(typeof(PackIconModernKind),
														       packIconKind);
							this.Icon = icon2;
							break;
						case "PackIconOcticons":
							var icon3 = new PackIconOcticons();
							((PackIconOcticons)icon3).Kind = (PackIconOcticonsKind)Enum
															.Parse(typeof(PackIconOcticonsKind),
														       packIconKind);
							this.Icon = icon3;
							break;
						case "PackIconSimpleIcons":
							var icon4 = new PackIconSimpleIcons();
							((PackIconSimpleIcons)icon4).Kind = (PackIconSimpleIconsKind)Enum
															.Parse(typeof(PackIconSimpleIconsKind),
														       packIconKind);
							this.Icon = icon4;
							break;
						case "PackIconEntypo":
							var icon5 = new PackIconEntypo();
							((PackIconEntypo)icon5).Kind = (PackIconEntypoKind)Enum
															.Parse(typeof(PackIconEntypoKind),
														       packIconKind);
							this.Icon = icon5;
							break;
						case "PackIconFontAwesome":
							var icon6 = new PackIconFontAwesome();
							((PackIconFontAwesome)icon6).Kind = (PackIconFontAwesomeKind)Enum
															.Parse(typeof(PackIconFontAwesomeKind),
														       packIconKind);
							this.Icon = icon6;
							break;
					}
					//this.Icon = icon;
				
				} else {
					if (codon.Properties.Contains("icon")) {
						try {
							var image = new Image();
							image.Source = PresentationResourceService.GetBitmapSource(codon.Properties["icon"]);
							image.Height = 16;
							this.Icon = image;
						} catch (ResourceNotFoundException) {}
					}											
				}				
			}
			
			if (codon.Properties.Contains("style")) {
				Style customStyle = Application.Current.TryFindResource("MenuItemStyleKey") as Style;
				
				if (customStyle != null) {
					this.Style = customStyle;
					this.UpdateLayout();
				}
			} else {
				//if (codon.Properties.Contains("packIconKey")) { //Apply material theme if PackIcon theme is used
					Style matStyle = Application.Current.TryFindResource("MaterialDesignMenuItem") as Style;
					if (matStyle != null)
						this.Style = matStyle;
				//}
			}
			
			UpdateText();
		}
		
		public void UpdateText()
		{			
			if (codon != null) {
				Header = MenuService.ConvertLabel(StringParser.Parse(codon.Properties["label"]));
			}			
		}
		
		public virtual void UpdateStatus()
		{
			ConditionFailedAction result = Condition.GetFailedAction(conditions, caller);
			if (result == ConditionFailedAction.Exclude)
				this.Visibility = Visibility.Collapsed;
			else
				this.Visibility = Visibility.Visible;
			if (SetEnabled)
				this.IsEnabled = result == ConditionFailedAction.Nothing;
		}
	}
}
