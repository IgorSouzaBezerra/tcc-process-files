import React from 'react';
import { Switch, Route, Redirect } from 'react-router-dom';

import Dash from '../pages/Dash';

import Process from '../pages/Process';
import ProcessDetails from '../pages/Process/ProcessDetails';

import ColumnControl from '../pages/ColumnControl';
import ColumnDetail from '../pages/ColumnControl/ColumnDetails';

import Job from '../pages/Job';

import MyProfile from '../pages/MyProfile';
import User from '../pages/User';

const SignRoutes = () => {
    return (
        <Switch>
            <Route path="/" exact component={Dash} />

            <Route path="/process/:endpoint" exact component={Process} />
            <Route path="/process/:company/:id" exact component={ProcessDetails} />
            
            <Route path="/column-controls" exact component={ColumnControl} />
            <Route path="/column-controls/:company" exact component={ColumnDetail} />

            <Route path="/job" exact component={Job} />

            <Route path="/myprofile/:id" exact component={MyProfile} />
            <Route path="/users" exact component={User} />
            <Redirect from="*" to="/" />
        </Switch>
    )
}

export default SignRoutes;