namespace Basket.API.Data
{
    public interface IBasketRepository
    {
        Task<ShoppingCart> GetBasket(string UserName, CancellationToken cancellationToken);
        Task<ShoppingCart> Storebasket(ShoppingCart Cart, CancellationToken cancellationToken);
        Task<bool> DeleteBasket(string UserName, CancellationToken cancellationToken);
    }
}
