namespace Basket.API.Basket.Deletebasket
{
    public record DeleteBasketCommand(string UserName) : ICommand<DeleteBasketResult>;
    public record DeleteBasketResult(bool IsSuccess);

    public class StoreBasketCommandValidator : AbstractValidator<DeleteBasketCommand>
    {
        public StoreBasketCommandValidator()
        {
            RuleFor(x => x.UserName).NotNull().WithMessage("UserName is required.");
        }
    }
    public class DeleteBasketCommandHandler (IBasketRepository repository)
        : ICommandHandler<DeleteBasketCommand, DeleteBasketResult>
    {
        public async Task<DeleteBasketResult> Handle(DeleteBasketCommand command, CancellationToken cancellationToken)
        {
            await repository.DeleteBasket(command.UserName, cancellationToken);
            return new DeleteBasketResult(true);
        }
    }
}
