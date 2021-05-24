import React, { createContext, useCallback, useContext, useEffect, useState } from 'react';
import { useHistory } from 'react-router-dom';

import api from '../services/api';
import { Error } from '../utils/toast';

import { useSummary } from './useSummary';

const AuthContext = createContext({});

export const AuthProvider = ({ children }) => {
    const history = useHistory();
    const[user, setUser] = useState("");
    const { loadSummary } = useSummary();

    useEffect(() => {
        const storagedUser = JSON.parse(sessionStorage.getItem('@USER'));

        if (storagedUser) {
            setUser(storagedUser);
            api.defaults.headers.Authorization = `Bearer ${storagedUser.token}`;
        }
    }, []);

    const Login = useCallback(async ({ email, password }) => {
        try{
            const response = await api.post(`Auth`, {
                email,
                password
            });

            setUser(response.data);
            api.defaults.headers.Authorization = `Bearer ${response.data.token}`;

            sessionStorage.setItem('@USER', JSON.stringify(response.data));

            await loadSummary();
        } catch(err) {
            if (err.response?.data)
                Error(err.response.data);
            else
                Error("Server Internal Error.");
        }
    }, [loadSummary]);

    const Logout = useCallback(() => {
        setUser(null);
        history.push('/');
        sessionStorage.removeItem('@USER');
    }, [history]);

    return (
      <AuthContext.Provider value={{ signed: Boolean(user), user, Login, Logout }}>
        {children}
      </AuthContext.Provider>
    );
};

export function useAuth () {
    const context = useContext(AuthContext);
    return context;
}

export default AuthContext;