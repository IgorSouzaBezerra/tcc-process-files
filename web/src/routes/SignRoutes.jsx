import React from 'react';
import { Switch, Route } from 'react-router-dom';

import Process from '../Pages/Process/Process';
import ProcessDetails from '../Pages/Process/ProcessDetails';

import ColumnControls from '../Pages/ColumnControls/Column Controls';
import ColumnControlsDetail from '../Pages/ColumnControls/Detail';
import ColumnControlsCreate from '../Pages/ColumnControls/Create';

import Job from '../Pages/Job';

import User from '../Pages/User/User';
import UserDetail from '../Pages/User/UserDetail';

const SignRoutes = () => {
    return (
        <Switch>
            <Route path="/" exact component={Process} />
            <Route path="/process/:company/:id" exact component={ProcessDetails} />

            <Route path="/column-controls" exact component={ColumnControls} />
            <Route path="/column-controls/create" exact component={ColumnControlsCreate} />
            <Route path="/column-controls/:company" exact component={ColumnControlsDetail} />

            <Route path="/job" exact component={Job} />

            <Route path="/users" exact component={User} />
            <Route path="/user/:id" exact component={UserDetail} />

            <Route component={() => <h1>Not Found</h1>} />
        </Switch>
    )
}

export default SignRoutes;
