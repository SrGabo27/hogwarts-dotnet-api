using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using hogwartsApi.Domain.Models;
using hogwartsApi.Domain.Services;
using hogwartsApi.Domain.Repositories;
using hogwartsApi.Domain.Services.Communication;

namespace hogwartsApi.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ApplicationService(IApplicationRepository applicationRepository, IUnitOfWork unitOfWork)
        {
            _applicationRepository = applicationRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Application>> ListAsync()
        {
            return await _applicationRepository.ListAsync();
        }

        public async Task<ApplicationResponse> SaveAsync(Application application)
        {
            try
            {
                await _applicationRepository.AddAsync(application);
                await _unitOfWork.CompleteAsync();

                return new ApplicationResponse(application);
            }
            catch (Exception ex)
            {
                return new ApplicationResponse($"An error occurred when saving the application: {ex.Message}");
            }
        }

        public async Task<ApplicationResponse> UpdateAsync(int id, Application application)
        {
            var existingApplication = await _applicationRepository.FindByIdAsync(id);

            if (existingApplication == null)
                return new ApplicationResponse("Application not found.");

            existingApplication.Name = application.Name;

            try
            {
                _applicationRepository.Update(existingApplication);
                await _unitOfWork.CompleteAsync();

                return new ApplicationResponse(existingApplication);
            }
            catch (Exception ex)
            {
                return new ApplicationResponse($"An error occurred when updating the application: {ex.Message}");
            }
        }

        public async Task<ApplicationResponse> DeleteAsync(int id)
        {
            var existingApplication = await _applicationRepository.FindByIdAsync(id);

            if (existingApplication == null)
                return new ApplicationResponse("Application not found.");

            try
            {
                _applicationRepository.Remove(existingApplication);
                await _unitOfWork.CompleteAsync();

                return new ApplicationResponse(existingApplication);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new ApplicationResponse($"An error occurred when deleting the application: {ex.Message}");
            }
        }
    }
}
