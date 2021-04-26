import React from 'react';
import { BrowserRouter as Router} from 'react-router-dom';

import { ToastContainer } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

import { ThemeProvider } from 'styled-components';
import usePersistedState from './utils/usePersistedState';
import { light } from './styles/theme/light';
import { dark } from './styles/theme/dark';

import Header from './components/Header';
import GlobalStyles from './styles/global';

import Routes from './routes';
import { AuthProvider } from './context/auth';

const App = () => {
    const[theme, setTheme] = usePersistedState('theme', light);

    const toggleTheme = () => {
        setTheme(theme.title === 'light' ? dark : light);
    };

    return (
        <ThemeProvider theme={theme}>
            <Router>
                <AuthProvider>
                    <Header toggleTheme={toggleTheme} />
                    <Routes />
                </AuthProvider>
                <GlobalStyles />
                <ToastContainer />
            </Router>
        </ThemeProvider>
    );
}

export default App;
