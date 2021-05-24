import React from 'react';
import { useAuth } from '../context/useAuth';

import SignRoutes from './SignRoutes';
import OtherRoutes from './OtherRoutes';

const Routes = () => {
    const { signed } = useAuth();

    return signed ? <SignRoutes /> : <OtherRoutes />;
}

export default Routes;