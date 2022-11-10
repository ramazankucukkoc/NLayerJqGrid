namespace Business.Messages.Product
{
    public class Product_Messages
    {
        public static readonly string CategoryLimitExceded = "Kategori sayısı 15'dir fazla yapılamaz";
        public static string ProdcutAdded = "Ürün Eklendi";
        public static string ProdcutDeleted = "Ürün Silindi";
        public static string ProdcutUpdated = "Ürün Güncellendi";
        public static string ProdcutGetall = "Ürün Listesi Getirildi";
        public static string ProdcutGet = "Tek Bir Id'ye göre Listelendi";
        public static string ProductWithCategoryId = "Kategori Id'ye göre Listelendi";
        public static string ProductWithProductId = "Product Id'ye gore ürün getirldi.";
        public static string ProductNameAlreadyExists = "ProductName is Already";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 15 ürün yer almalıdır.";
    }
}
