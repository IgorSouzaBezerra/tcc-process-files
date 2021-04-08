import axios from 'axios';
import { verify } from 'jsonwebtoken';

const api = axios.create({
    baseURL: 'http://localhost:5000/',
});

const token = sessionStorage.getItem('@TOKEN');
api.interceptors.response.use(
    response => Promise.resolve(response),
    error => {
        verify(token, '8d73f8d1a4ad40ec983e6c1737e169de', function(err, decoded) {
            if (err.message === 'jwt expired') {
                console.log('expirado')
            }
        })
    }
)

export default api;