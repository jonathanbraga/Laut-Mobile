using Laut.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Laut.Services.Interfaces
{
    public interface ILautData
    {
        ObservableCollection<Menu> GetMenuItens();
        ObservableCollection<Service> GetServices();
        ObservableCollection<Project> GetProjects();
        ObservableCollection<Product> GetProducts();
    }
}
