﻿using Supermarket_mvp._Repositories;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowProductView += ShowProductView;
            this.mainView.ShowCategoriesView += ShowCategoriesView;
            this.mainView.ShowProvidersView += ShowProvidersView;
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view =  PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }


        private void ShowCategoriesView(object? sender, EventArgs e)
        {
            ICategoriesView view = CategoriesView.GetInstance((MainView)mainView);
            ICategoriesRepository repository = new CategoriesRepository(sqlConnectionString);
            new CategoriesPresenter(view, repository);
        }


        private void ShowProvidersView(object? sender, EventArgs e)
        {
            IProvidersView view = ProvidersView.GetInstance((MainView)mainView);
            IProvidersRepository repository = new ProvidersRepository(sqlConnectionString);
            new ProvidersPresenter(view, repository);
        }


    }
}
