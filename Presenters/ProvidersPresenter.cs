using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class ProvidersPresenter
    {

        private IProvidersView view;
        private IProvidersRepository repository;
        private BindingSource providersBindingSource;
        private IEnumerable<ProvidersModel> providersList;

        public ProvidersPresenter(IProvidersView view, IProvidersRepository repository)
        {
            this.providersBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProviders;
            this.view.AddNewEvent += AddNewProviders;
            this.view.EditEvent += LoadSelectProvidersToEdit;
            this.view.DeleteEvent += DeleteSelectedProviders;
            this.view.SaveEvent += SaveProviders;
            this.view.CancelEvent += CancelAction;

            this.view.SetProvidersListBildingSource(providersBindingSource);

            loadAllProvidersList();

            this.view.Show();

        }

        private void loadAllProvidersList()
        {
            providersList = repository.GetAll();
            providersBindingSource.DataSource = providersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProviders(object? sender, EventArgs e)
        {
            // se crea un objeto de la clase ProvidersModel y se asignano los datos de las cajas de texto de la vista.

            var providers = new ProvidersModel();
            providers.Id = Convert.ToInt32(view.ProvidersId);
            providers.Document_Number = view.ProvidersDocument;
            providers.First_Name = view.ProvidersFirstName;
            providers.Last_Name = view.ProvidersLastName;
            providers.Address = view.ProvidersAddress;
            providers.Phone_Number = view.ProvidersPhone;
            providers.Email = view.ProvidersEmail;

            try
            {
                new Common.ModelDataValidation().Validate(providers);
                if (view.IsEdit)
                {
                    repository.Edit(providers);
                    view.Message = "Providers edited successfully";

                }
                else
                {
                    repository.Add(providers);
                    view.Message = "Providers added successfully";
                }
                view.IsSuccessful = true;
                loadAllProvidersList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                // si ocurre una excepción se configura IsSuccesfull en false y a la propiedad Message de la vista se asigna el mensaje de la excepción

                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProvidersId = "0";
            view.ProvidersDocument = "";
            view.ProvidersFirstName = "";
            view.ProvidersLastName = "";
            view.ProvidersAddress = "";
            view.ProvidersBirthday = "";
            view.ProvidersPhone = "";
            view.ProvidersEmail = "";
        }

        private void DeleteSelectedProviders(object sender, EventArgs e)
        {
            try
            {
                // Se recupera el objeto de la fila seleccionada del dataviewgrid
                var providers = (ProvidersModel)providersBindingSource.Current;

                // Se invoca el metodo Delete del repositorio pasandole el ID del Providers
                repository.Delete(providers.Id);
                view.IsSuccessful = true;
                view.Message = "Providers deleted successfully";
                loadAllProvidersList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete providers";
            }
        }

        private void LoadSelectProvidersToEdit(object? sender, EventArgs e)
        {
            // se obtiene el objeto del datagridview que se encuentra seleccionado.
            var providers = (ProvidersModel)providersBindingSource.Current;

            // se cambia el contenido de las cajas de texto por el objeto recuperado del datagridvewi.

            providers.Id = Convert.ToInt32(view.ProvidersId);
            providers.Document_Number = view.ProvidersDocument;
            providers.First_Name = view.ProvidersFirstName;
            providers.Last_Name = view.ProvidersLastName;
            providers.Address = view.ProvidersAddress;
            providers.Phone_Number = view.ProvidersPhone;
            providers.Email = view.ProvidersEmail;

            // se establece el modo como edición.
            view.IsEdit = true;
        }

        private void AddNewProviders(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProviders(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providersList = repository.GetAll();
            }
            providersBindingSource.DataSource = providersList;
        }


    }
}
