namespace Basket.API.Data
{
    public class BasketRespository
        (IDocumentSession session)
        : IBasketRepository
    {
        public async Task<ShoppingCart> GetBasket(string userName, CancellationToken cancellationToken)
        {
            var basket = await session.LoadAsync<ShoppingCart>(userName, cancellationToken);

            return basket is null ? throw new BasketNotFoundException(userName) : basket;
        }
        public async Task<ShoppingCart> Storebasket(ShoppingCart Basket, CancellationToken cancellationToken)
        {
            session.Store(Basket);
            await session.SaveChangesAsync(cancellationToken);
            return Basket;
        }
        public async Task<bool> DeleteBasket(string UserName, CancellationToken cancellationToken)
        {
            session.Delete<ShoppingCart>(UserName);
            await session.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
