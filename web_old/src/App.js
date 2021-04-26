import React from 'react';
import { BrowserRouter as Router} from 'react-router-dom';
import { ToastContainer } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

import GlobalStyle from './style/global';

import Routes from './routes';

import { AuthProvider } from './context/auth';

function App() {
  return (
    <Router>
      <AuthProvider>
        <Routes />
      </AuthProvider>
      
      <ToastContainer />
      <GlobalStyle />
    </Router>
  );
}

export default App;
