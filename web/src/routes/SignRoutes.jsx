import React from 'react';
import { Switch, Route, Redirect } from 'react-router-dom';

import Dash from '../pages/Dash';

import Process from '../pages/Process';
import ProcessDetails from '../pages/Process/ProcessDetails';

import Job from '../pages/Job';

import MyProfile from '../pages/MyProfile';

const SignRoutes = () => {
    return (
        <Switch>
            <Route path="/" exact component={Dash} />

            <Route path="/process/:endpoint" exact component={Process} />
            <Route path="/process/:company/:id" exact component={ProcessDetails} />
            
            <Route path="/job" exact component={Job} />

            <Route path="/myprofile/:id" exact component={MyProfile} />
            <Redirect from="*" to="/" />
        </Switch>
    )
}

export default SignRoutes;