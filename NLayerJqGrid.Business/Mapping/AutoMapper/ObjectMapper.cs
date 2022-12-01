using AutoMapper;

namespace Business.Mapping.AutoMapper
{
	public static class ObjectMapper
	{
		private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
		{
			var config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<ProductMapping>();
			});
			return config.CreateMapper();
		});
		public static IMapper Mapper => lazy.Value;

	}
}
