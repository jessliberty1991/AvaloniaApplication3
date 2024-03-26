using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Markup.Xaml.Templates;
using AvaloniaApplication3.ViewModels;
using System;

namespace AvaloniaApplication3
{
    public class ViewLocator : IDataTemplate
    {
        public Control Build(object? data)
        {
            var name = data?.GetType().FullName!.Replace("ViewModel", "View");
            if (name != null)
            {
                var type = Type.GetType(name);


                if (type != null)
                {
                    return (Control)Activator.CreateInstance(type)!;
                }
                else
                {
                    return new TextBlock { Text = "Not Found: " + name };
                }
            }
            return new TextBlock () ;
        }
        

        public bool Match(object? data)
        {
            return data is ViewModelBase;
        }

       
    }
}
