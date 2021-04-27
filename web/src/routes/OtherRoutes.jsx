import React from 'react';
import { Switch, Route, Redirect } from 'react-router-dom';

import Signin from '../pages/Signin';

const OtherRoutes = () => {
    return (
        <Switch>
            <Route path="/" exact component={Signin} />
            <Redirect from="*" to="/" />
        </Switch>
    );
}

export default OtherRoutes;