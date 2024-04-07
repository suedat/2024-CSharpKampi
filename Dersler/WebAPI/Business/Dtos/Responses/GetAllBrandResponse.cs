namespace Business.Dtos.Responses;

//aynı dtoyu her şey için kullanmak hatadır.
//kayıt ile listeleme için farklı kayıt isteriz

public class GetAllBrandResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }

    internal void Add(GetAllBrandResponse getAllBrandResponse)
    {
        throw new NotImplementedException();
    }
}

