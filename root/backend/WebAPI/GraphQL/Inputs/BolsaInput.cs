namespace WebAPI.GraphQL.Inputs
{
    public record AddBolsaInput 
    (
        int IdMercaderia,
        double PesoKg,
        int? PrecioVenta,
        int? PrecioCompra
    );
    public record DeleteBolsaInput
    (
        int IdBolsa
    );
    public record UpdateBolsaInput
    (
        int IdBolsa,
        int IdMercaderia,
        double PesoKg,
        int? PrecioVenta,
        int? PrecioCompra
    );
}
