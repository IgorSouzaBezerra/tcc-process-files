import React from 'react';

import { Switch, Route } from 'react-router-dom';

import SignIn from '../Pages/SignIn/index';

const OtherRoutes = () => {
    return (
        <Switch>
            <Route path="/" exact component={SignIn} />
        </Switch>
    );
}

export default OtherRoutes;
