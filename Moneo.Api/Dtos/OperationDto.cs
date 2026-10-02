namespace Moneo.Api.Dtos;

public record OperationDto(
    Guid Id,
    string Label,
    decimal Amount,
    DateTime Date,
    Guid AccountId,
    Guid? CategoryId,
    string? CategoryLabel
    );