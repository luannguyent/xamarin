using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace PersonalApp.Views.CustomControl
{
    /// <summary>
    /// https://github.com/ThatCSharpGuy/FormattedNumberEntry
    /// </summary>
    public class CustomEntry : Entry
    {
        public static readonly BindableProperty ValueProperty =
            BindableProperty.Create(nameof(Value), typeof(int), typeof(CustomEntry), 0);

        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public bool ShouldReactToTextChanges { get; set; }
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (nameof(this.Text).Equals(propertyName))
            {
                var oldText = this.Text;
                var number = ParseToDouble(oldText);
                var newText = $"{number:#,###}";

                this.Text = newText;
            }
            base.OnPropertyChanged(propertyName);
        }

        public static int ParseToDouble(string input)
        {
            var number = 0;
            int multiply = 1;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (Char.IsDigit(input[i]))
                {
                    number += (input[i] - '0') * (multiply);
                    multiply *= 10;
                }
            }
            return number;
        }
    }
}
