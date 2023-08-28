namespace Employees_Application.Service.Services{
    public class AuthResult{
        public bool SuccessV {get; private set;}
        public string Token {get; private set;}
        public List<string> Errors {get; private set;}

        private AuthResult(bool success, string token, List<string> errors) {
            SuccessV  = success;
            Token = token; 
            Errors = errors;
        }

        public static AuthResult Success(string token = null){
            return new AuthResult(true, token, null);
        }

        public static AuthResult Failure(List<string> errors){
            return new AuthResult(false, null, errors);
        }

        public static AuthResult Failure(string errors){
            return new AuthResult(false, null, new List<string>{errors});
        }
    }
}