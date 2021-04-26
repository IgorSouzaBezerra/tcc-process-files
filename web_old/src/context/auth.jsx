import React, { createContext, useCallback, useContext, useEffect, useState } from 'react';
import { useHistory } from 'react-router-dom';

import api from '../services/api';
import { Error } from '../utils/toast';

const AuthContext = createContext({});

export const AuthProvider = ({ children }) => {
    const history = useHistory();
    const[token, setToken] = useState("");

    useEffect(() => {
        const storagedToken = sessionStorage.getItem('@TOKEN');

        if (storagedToken) {
            setToken(storagedToken);
            api.defaults.headers.Authorization = `Bearer ${storagedToken}`;
        }
    }, []);

    const Login = useCallback(async ({ email, password }) => {
        try{
            const response = await api.post(`Auth`, {
                email,
                password
            });
            
            setToken(response.data);
            api.defaults.headers.Authorization = `Bearer ${response.data}`;

            sessionStorage.setItem('@TOKEN', response.data);
        } catch(err) {
            if (err.response?.data)
                Error(err.response.data);
            else
                Error("Server Internal Error.");
        }
    }, []);

    const Logout = useCallback(() => {
        setToken(null);
        history.push('/');
        sessionStorage.removeItem('@TOKEN');
    }, [history]);

    return (
      <AuthContext.Provider value={{ signed: Boolean(token), Login, Logout }}>
        {children}
      </AuthContext.Provider>
    );
};

export function useAuth () {
    const context = useContext(AuthContext);
    return context;
}

export default AuthContext;