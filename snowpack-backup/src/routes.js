import React from "react";
import { Switch, Route } from "react-router-dom";
// import Gallery from "./Gallery.js";
import Styleguide from "./Styleguide.js";
import Home from "./Home.js";
// import Movies from "./Movies.js";

export default () => (
  <Switch>
    <Route exact path="/" component={Home} />
    {/* <Route path="/gallery" component={Gallery} /> */}
    <Route path="/styleguide" component={Styleguide} />
    {/* <Route path="/movies" component={Movies} /> */}
  </Switch>
);
