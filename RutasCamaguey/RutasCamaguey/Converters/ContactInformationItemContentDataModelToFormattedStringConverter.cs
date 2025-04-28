namespace MOROPO.InfoTur.Camaguey.Rutas.Converters
{
    public class ContactInformationItemContentDataModelToFormattedStringConverter : Xamarin.Forms.IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) return null;

            var model = (System.Collections.Generic.KeyValuePair<string, Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem>)value;

            var result = new Xamarin.Forms.FormattedString();

            result.Spans.Add(new Xamarin.Forms.Span
            {
                Text = $"{model.Key}:",
                TextDecorations = Xamarin.Forms.TextDecorations.Underline
            });

            if (!string.IsNullOrEmpty(model.Value.Address))
            {
                result.Spans.Add(new Xamarin.Forms.Span { Text = " " });
                result.Spans.Add(new Xamarin.Forms.Span
                {
                    Text = model.Value.Address
                });
            }

            if (!string.IsNullOrEmpty(model.Value.Phones))
            {
                if (result.Spans.Count > 1)
                {
                    result.Spans.Add(new Xamarin.Forms.Span { Text = ", " });
                }
                else
                {
                    result.Spans.Add(new Xamarin.Forms.Span { Text = " " });
                }

                var phonesTapGestureRecognizer = new Xamarin.Forms.TapGestureRecognizer();

                phonesTapGestureRecognizer.Tapped += (sender, args) =>
                {
                    var _model = (System.Collections.Generic.KeyValuePair<string, Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem>)(sender as Xamarin.Forms.BindableObject).BindingContext;

                    Xamarin.Essentials.Launcher.TryOpenAsync(new System.Uri($"tel:{_model.Value.Phones}"));
                };

                var phonesSpan = new Xamarin.Forms.Span
                {
                    Text = model.Value.Phones,
                    TextDecorations = Xamarin.Forms.TextDecorations.Underline,
                    TextColor = Xamarin.Forms.Color.Blue
                };

                phonesSpan.GestureRecognizers.Add(phonesTapGestureRecognizer);

                result.Spans.Add(phonesSpan);
            }

            if (!string.IsNullOrEmpty(model.Value.WebSite))
            {
                if (result.Spans.Count > 1)
                {
                    result.Spans.Add(new Xamarin.Forms.Span { Text = ", " });
                }
                else
                {
                    result.Spans.Add(new Xamarin.Forms.Span { Text = " " });
                }

                var webSiteTapGestureRecognizer = new Xamarin.Forms.TapGestureRecognizer();

                webSiteTapGestureRecognizer.Tapped += (sender, args) =>
                {
                    var _model = (System.Collections.Generic.KeyValuePair<string, Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem>)(sender as Xamarin.Forms.BindableObject).BindingContext;

                    Xamarin.Essentials.Launcher.TryOpenAsync(new System.Uri($"http://{_model.Value.WebSite}"));
                };

                var webSiteSpan = new Xamarin.Forms.Span
                {
                    Text = model.Value.WebSite,
                    TextDecorations = Xamarin.Forms.TextDecorations.Underline,
                    TextColor = Xamarin.Forms.Color.Blue
                };

                webSiteSpan.GestureRecognizers.Add(webSiteTapGestureRecognizer);

                result.Spans.Add(webSiteSpan);
            }

            return result;
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
    }
}
