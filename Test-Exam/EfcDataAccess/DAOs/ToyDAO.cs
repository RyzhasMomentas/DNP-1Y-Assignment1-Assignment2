namespace EfcDataAccess.DAOs;

public class ToyDAO
{
    private readonly DataContext context;

    public ToyDAO(DataContext context)
    {
        this.context = context;
    }
    
}