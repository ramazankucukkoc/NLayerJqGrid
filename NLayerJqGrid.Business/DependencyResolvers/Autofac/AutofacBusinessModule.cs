
using Autofac;
using Business.Concrete;
using NLayerJqGrid.Business.Abstract;
using NLayerJqGrid.Business.Concrete;
using NLayerJqGrid.DataAccess.Abstract;
using NLayerJqGrid.DataAccess.Concrete.EntityFramework;
using NLayerJqGrid.DataAccess.DataAccess.Abstract;
using NLayerJqGrid.DataAccess.DataAccess.Concrete.EntityFramework;
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

			builder.RegisterType<CustomerManager>().As<ICustomerService>();
			builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

			builder.RegisterType<CustomerTransactionManager>().As<ICustomerTransactionService>();
			builder.RegisterType<EfCustomerTransactions>().As<ICustomerTransactionDal>();

			builder.RegisterType<PersonelManager>().As<IPersonelService>();
			builder.RegisterType<EfPersonelDal>().As<IPersonelDal>();

		}
	}
}
