using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class CategoriesPresenter
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;
        private BindingSource categoriesBindingSource;
        private IEnumerable<CategoriesModel> categoriesList;

        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.categoriesBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategories;
            this.view.AddNewEvent += AddNewCategories;
            this.view.EditEvent += LoadSelectCategoriesToEdit;
            this.view.DeleteEvent += DeleteSelectedCategories;
            this.view.SaveEvent += SaveCategories;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoriesListBildingSource(categoriesBindingSource);

            loadAllCategoriesList();

            this.view.Show();

        }

        private void loadAllCategoriesList()
        {
            categoriesList = repository.GetAll();
            categoriesBindingSource.DataSource = categoriesList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategories(object? sender, EventArgs e)
        {
            // se crea un objeto de la clase CategoriesModel y se asignan los datos de las cajas de texto de la vista.

            var categories = new CategoriesModel();
            categories.Id = Convert.ToInt32(view.CategoriesId);
            categories.Name = view.CategoriesName;
            categories.Description = view.CategoriesDescription;

            try
            {
                new Common.ModelDataValidation().Validate(categories);
                if (view.IsEdit)
                {
                    repository.Edit(categories);
                    view.Message = "Categories edited successfully";

                }
                else
                {
                    repository.Add(categories);
                    view.Message = "Categories added successfully";
                }
                view.IsSuccessful = true;
                loadAllCategoriesList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                // si ocurre una excepción se configura IsSuccessful en false y a la propiedad Message de la vista se asigna el mensaje de la excepción

                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.CategoriesId = "0";
            view.CategoriesName = "";
            view.CategoriesDescription = "";
        }

        private void DeleteSelectedCategories(object sender, EventArgs e)
        {
            try
            {
                // Se recupera el objeto de la fila seleccionada del DataGridView
                var categories = (CategoriesModel)categoriesBindingSource.Current;

                // Se invoca el método Delete del repositorio pasándole el ID de la categoría
                repository.Delete(categories.Id);
                view.IsSuccessful = true;
                view.Message = "Category deleted successfully";
                loadAllCategoriesList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete category";
            }
        }

        private void LoadSelectCategoriesToEdit(object? sender, EventArgs e)
        {
            // se obtiene el objeto del DataGridView que se encuentra seleccionado.
            var categories = (CategoriesModel)categoriesBindingSource.Current;

            // se cambia el contenido de las cajas de texto por el objeto recuperado del DataGridView.

            view.CategoriesId = categories.Id.ToString();
            view.CategoriesName = categories.Name;
            view.CategoriesDescription = categories.Description;

            // se establece el modo como edición.
            view.IsEdit = true;
        }

        private void AddNewCategories(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategories(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue)
            {
                categoriesList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoriesList = repository.GetAll();
            }
            categoriesBindingSource.DataSource = categoriesList;
        }

    }
}
