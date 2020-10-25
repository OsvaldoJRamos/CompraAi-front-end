using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CompraAi.Uteis
{
    [ContentProperty(nameof(Source))]
    public class ExtensaoRecursosImagem : IMarkupExtension
    {
        public string Source { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;

            var recursoImagem = ImageSource
                .FromResource(Source, typeof(ExtensaoRecursosImagem).GetTypeInfo().Assembly);

            return recursoImagem;
        }
    }
}
