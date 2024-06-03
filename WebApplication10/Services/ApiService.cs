using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TrainingCourse>> GetTrainingCoursesAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<TrainingCourse>>("https://localhost:5001/api/TrainingCourses");
            return response;
        }

        public async Task<TrainingCourse> GetTrainingCourseAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<TrainingCourse>($"https://localhost:5001/api/TrainingCourses/{id}");
            return response;
        }

        public async Task<HttpResponseMessage> CreateTrainingCourseAsync(TrainingCourse trainingCourse)
        {
            var response = await _httpClient.PostAsJsonAsync("https://localhost:5001/api/TrainingCourses", trainingCourse);
            return response;
        }

        public async Task<HttpResponseMessage> UpdateTrainingCourseAsync(TrainingCourse trainingCourse)
        {
            var response = await _httpClient.PutAsJsonAsync($"https://localhost:5001/api/TrainingCourses/{trainingCourse.Id}", trainingCourse);
            return response;
        }

        public async Task<HttpResponseMessage> DeleteTrainingCourseAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"https://localhost:5001/api/TrainingCourses/{id}");
            return response;
        }
    }
}
