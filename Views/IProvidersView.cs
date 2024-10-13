using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IProvidersView
    {

        string ProvidersId { get; set; }
        string ProvidersDocument { get; set; }
        string ProvidersFirstName { get; set; }
        string ProvidersLastName { get; set; }
        string ProvidersAddress { get; set; }
        string ProvidersBirthday { get; set; }
        string ProvidersPhone { get; set; }
        string ProvidersEmail { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProvidersListBildingSource(BindingSource providersBindingSource);
        void Show();


    }
}
