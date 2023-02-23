using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTabQueryRepro
{
    public class PageViewModel<T> : IQueryAttributable where T : Page
    {
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Console.WriteLine($"{typeof(T).Name}ViewModel.ApplyQueryAttributes(\n{string.Join(",\n", query.Select(q => $"{q.Key}={q.Value}"))}\n)");
        }
    }
}
