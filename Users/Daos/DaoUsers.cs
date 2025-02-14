using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Users.Context;
using Users.Interfaces;
using Users.ResultPattern;

namespace Users.Daos
{
    public class DaoUsers : IDaoUsers
    {
        private readonly UsersContext _context;

        public DaoUsers(UsersContext context)
        {
            _context = context;

        }

        public async Task<OperationResult<string>> CreateAsync(Entities.Users entity)
        {
            if (entity == null)
                return await OperationResult<string>.FailureAsync("Ocurrio un error, La entidad no puede ser nula");

            if (string.IsNullOrWhiteSpace(entity.Name) || string.IsNullOrWhiteSpace(entity.Email) || entity.Birthdate == null)
                return await OperationResult<string>.FailureAsync("No se admiten valores nulos o vacios");

            if (entity.Name.Length > 100 || entity.Email.Length > 100)
                return await OperationResult<string>.FailureAsync("los valores exceden la cantidad permitida");

            try
            {
                await _context.AddAsync(entity);
                var result = await _context.SaveChangesAsync();

                return result > 0
                ? await OperationResult<string>.SuccessAsync("Operación realizada con éxito")
                : await OperationResult<string>.FailureAsync("Error guardando los datos en la base de datos");
            }
            catch (Exception ex)
            {
                return await OperationResult<string>.FailureAsync($"Error inesperado: {ex.Message}");
            }
        }

        public async Task<OperationResult<string>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Entities.Users>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Entities.Users> GetEntityByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult<string>> UpdateAsync(Entities.Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
