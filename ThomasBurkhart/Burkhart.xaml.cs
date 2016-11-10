// /*******************************************************************
//  *
//  * Burkhart.xaml.cs copyright 2016 ben, 42nd Parallel - ALL RIGHTS RESERVED.
//  *
//  *******************************************************************/
using System;
using System.Collections.Generic;
using Forms9Patch;
using Xamarin.Forms;

namespace ThomasBurkhart
{
	public partial class Burkhart : ContentPage
	{
		public Burkhart()
		{
			InitializeComponent();

			ImageButton.DefaultState = new ImageButtonState() { Text = "ImageButton", BackgroundColor = Color.FromHex("84849B"), FontColor = Color.Black };
			ImageButton.DisabledState = new ImageButtonState() { FontColor = Color.Gray };

			MaterialButton.Text = "MaterialButton";
			MaterialButton.FontColor = Color.Black;
			MaterialButton.BackgroundColor = Color.FromHex("84849B");

			EnableButtons.Text = "Disable Buttons";
			EnableButtons.Tapped += (sender, e) =>
			{
				ImageButton.IsEnabled = !ImageButton.IsEnabled;
				MaterialButton.IsEnabled = !MaterialButton.IsEnabled;
				EnableButtons.Text = ImageButton.IsEnabled ? "Disable Buttons" : "Enable Buttons";
			};
		}
	}
}
