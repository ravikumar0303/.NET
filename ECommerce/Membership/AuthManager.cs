
namespace Membership;
public static class AuthManager
{
    public static bool Validate(string email, string password){
        bool status=false;
        if(email == "ravi.tambade@transflower.in"
        && password=="iet"){
            status=true;
        }
        return status;
    }
    public static bool Register(string email, string password){
        bool status =false;

        //Store credentials into storage

        return status;
    }

}

