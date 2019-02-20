using XamarinCustomControls.CustomControls.Enums;
using XamarinCustomControls.CustomControls.Factories;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace XamarinCustomControls.CustomControls
{
    public class CustomEntry : StackLayout
    {

        #region Variables
        private Entry entry;
        private Label label;

        public bool IsPassword { get; set; }
        public string Placeholder { get; set; }
        public Color PlaceholderColor { get; set; }
        public string Text { get; set; }
        public Color TextColor { get; set; }
        public BorderColor BorderColor { get; set; }
        public FontAttributes FontAttributes { get; set; }
        public string FontFamily { get; set; }
        public double FontSize { get; set; }
        public bool IsTextPredictionEnabled { get; set; }
        public int MaxLength { get; set; }
        public Keyboard Keyboard { get; set; }
        public bool IsSpellCheckEnabled { get; set; }
        public TextAlignment HorizontalTextAlignment { get; set; }
        public ReturnType ReturnType { get; set; }
        public event EventHandler<TextChangedEventArgs> TextChanged;
        public event EventHandler Completed;

        public string LableText { get; set; }
        public TextAlignment LabelVerticalTextAlignment { get; set; }
        public double LabelFontSize { get; set; }
        public TextAlignment LabelHorizontalTextAlignment { get; set; }
        public FormattedString LabelFormattedText { get; set; }
        public LineBreakMode LabelLineBreakMode { get; set; }
        #endregion

        #region Constructors
        public CustomEntry()
        {
            ResetProperties();
            InitializeControls();
        }
        #endregion

        #region Methods
        protected override void OnParentSet()
        {
            base.OnParentSet();
            if (BorderColor != null)
                entry = EntryFactory.GetEntry(BorderColor);
            Bind();
            this.Children.Add(label);
            this.Children.Add(entry);
        }

        private void InitializeControls()
        {
            label = new Label();
            entry = new Entry();
        }
        private void Bind()
        {
            label.Text = LableText;
            if (IsPassword)
                entry.IsPassword = IsPassword;
            if (!string.IsNullOrEmpty(Placeholder) && !string.IsNullOrWhiteSpace(Placeholder))
                entry.Placeholder = Placeholder;
            if (PlaceholderColor != null && PlaceholderColor != Color.Transparent)
                entry.PlaceholderColor = PlaceholderColor;
            if (!string.IsNullOrEmpty(Text) && !string.IsNullOrWhiteSpace(Text))
                entry.Text = Text;
            if (TextColor != null && TextColor != Color.Transparent)
                entry.TextColor = TextColor;
            if (FontAttributes != FontAttributes.None)
                entry.FontAttributes = FontAttributes;
            if (!string.IsNullOrEmpty(FontFamily) && !string.IsNullOrWhiteSpace(FontFamily))
                entry.FontFamily = FontFamily;
            if (FontSize != null && FontSize > 0)
                entry.FontSize = FontSize;
            if (!IsTextPredictionEnabled)
                entry.IsTextPredictionEnabled = IsTextPredictionEnabled;
            if (MaxLength != null && MaxLength > 0)
                entry.MaxLength = MaxLength;
            if (IsSpellCheckEnabled)
                entry.IsSpellCheckEnabled = IsSpellCheckEnabled;
            if (Keyboard != Keyboard.Default)
                entry.Keyboard = Keyboard;
            if (ReturnType != ReturnType.Default)
                entry.ReturnType = ReturnType;
            if (TextChanged != null)
                entry.TextChanged += TextChanged;
            if (Completed != null)
                entry.Completed += Completed;
            if (HorizontalTextAlignment != null)
                entry.HorizontalTextAlignment = HorizontalTextAlignment;
            entry.HorizontalOptions = LayoutOptions.FillAndExpand;
            entry.VerticalOptions = LayoutOptions.FillAndExpand;

            label.VerticalTextAlignment = LabelVerticalTextAlignment;
            if (LabelFontSize != null && LabelFontSize > 0)
                label.FontSize = LabelFontSize;
            if (HorizontalTextAlignment != null)
                label.HorizontalTextAlignment = LabelHorizontalTextAlignment;
            if (LabelLineBreakMode != null)
                label.LineBreakMode = LabelLineBreakMode;
            if (TextColor != null && TextColor != Color.Transparent)
                label.TextColor = TextColor;
            if (FontSize != null && FontSize > 0)
                label.FontSize = FontSize + 3;

            label.TranslateTo(0, 40, 500, Easing.Linear);

            entry.Focused += Entry_Focused;
            entry.Unfocused += Entry_Unfocused;
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrEmpty(entry.Text) && string.IsNullOrWhiteSpace(entry.Text))
            {
                label.TranslateTo(0, 40, 500, Easing.Linear);
                if (FontSize != null && FontSize > 0)
                    label.FontSize = FontSize + 3;
            }
        }

        private void CustomizeStyles()
        {
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            label.TranslateTo(0, 20, 500, Easing.Linear);
            if (FontSize != null && FontSize > 0)
                label.FontSize = FontSize;
        }

        private void ResetProperties()
        {
            IsPassword = false;
            Placeholder = null;
            PlaceholderColor = Color.Transparent;
            Text = null;
            FontAttributes = FontAttributes.None;
            FontFamily = null;
            FontSize = 0;
            IsTextPredictionEnabled = false;
            MaxLength = 0;
            IsSpellCheckEnabled = false;
            Keyboard = Keyboard.Default;
            ReturnType = ReturnType.Default;
            LabelFontSize = 0;
            BorderColor = BorderColor.Black;
        }

        #endregion

        #region Getters
        public Entry GetEntry()
        {
            return entry;
        }
        public string GetText()
        {
            return entry.Text;
        }
        #endregion

    }
}
