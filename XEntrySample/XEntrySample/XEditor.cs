using Xamarin.Forms;

namespace XEntrySample.Controls
{
    public class XEditor : Editor
    {
        public static readonly BindableProperty XHighlightColorProperty
            = BindableProperty.Create(nameof(XHighlightColor), typeof(Color), typeof(XEntry), Color.Transparent);

        public static readonly BindableProperty XHandleColorProperty
            = BindableProperty.Create(nameof(XHandleColor), typeof(Color), typeof(XEntry), Color.Transparent);

        public static readonly BindableProperty XBorderColorProperty
            = BindableProperty.Create(nameof(XBorderColor), typeof(Color), typeof(XEntry), Color.Transparent);

        public static readonly BindableProperty XCornerRadiusProperty
            = BindableProperty.Create(nameof(XCornerRadius), typeof(int), typeof(XEntry), 0);

        public static readonly BindableProperty XBorderWidthProperty
            = BindableProperty.Create(nameof(XBorderWidth), typeof(int), typeof(XEntry), 0);

        public static readonly BindableProperty XPaddingProperty
            = BindableProperty.Create(nameof(XPadding), typeof(Thickness), typeof(XEntry), new Thickness(5));


        public Color XHighlightColor {
            get => (Color)GetValue(XHighlightColorProperty);
            set => SetValue(XHighlightColorProperty, value);
        }

        public Color XHandleColor {
            get => (Color)GetValue(XHandleColorProperty);
            set => SetValue(XHandleColorProperty, value);
        }

        public Color XBorderColor {
            get => (Color)GetValue(XBorderColorProperty);
            set => SetValue(XBorderColorProperty, value);
        }

        public int XCornerRadius {
            get => (int)GetValue(XCornerRadiusProperty);
            set => SetValue(XCornerRadiusProperty, value);
        }

        public int XBorderWidth {
            get => (int)GetValue(XBorderWidthProperty);
            set => SetValue(XCornerRadiusProperty, value);
        }

        public Thickness XPadding {
            get => (Thickness)GetValue(XPaddingProperty);
            set => SetValue(XCornerRadiusProperty, value);
        }
    }
}
