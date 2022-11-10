
using Autofac;
using Business.Concrete;
using NLayerJqGrid.Business.Abstract;
using NLayerJqGrid.DataAccess.Abstract;
using NLayerJqGrid.DataAccess.Concrete.EntityFramework;
using System.Reflection;
using Module = Autofac.Module;
namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(global::Autofac.ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            

            
        }
    }
}
