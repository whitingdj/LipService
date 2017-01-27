using System;

namespace LipService {
    public interface IUserService {
        void Create(User user);
        void Authenticate(string username, string password);
    }
}
