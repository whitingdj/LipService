using System;

namespace LipService {
    public interface IAccountService {
        void Create(User user);
        void Authenticate(string username, string password);
    }
}
