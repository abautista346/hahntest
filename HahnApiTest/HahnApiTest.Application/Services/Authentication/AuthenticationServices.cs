namespace HahnApiTest.Application.Services.Authentication;

public class AuthenticationServices 
{
    public AuthenticationResult Login(string email, string password)
    {
        return findUser(email,password);
    }

    public AuthenticationResult Register(string firstname, string lastName, string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            firstname,
            lastName,
            email,
            "token");
    }

    private AuthenticationResult findUser(string user, string pass)
    {
        
        switch(user){
            case "abautistausac@gmail.com":

                if(pass=="12345")
                {
                    return new AuthenticationResult(
                        Guid.NewGuid(),
                        "Alan",
                        "Bautista",
                        user,
                        (Guid.NewGuid()).ToString() );
                }else
                {
                    break;
                }
                
                
            case "otrousuario@yahoo.es" :
            if(pass=="1234")
                {
                    return new AuthenticationResult(
                        Guid.NewGuid(),
                        "Otro",
                        "usuarios",
                        user,
                         (Guid.NewGuid()).ToString());
                }else
                {
                    break;
                }

        }


        return null;
    }
    
}