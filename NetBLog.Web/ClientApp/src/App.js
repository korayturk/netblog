import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './layout/Layout';
import { Home } from './screen/Home';
import { Blog } from './screen/Blog';
import { About } from './screen/About';
import { Contact } from './screen/Contact';

import './style/custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route exact path='/blog' component={Blog} />
        <Route exact path='/about' component={About} />
        <Route exact path='/contact' component={Contact} />
      </Layout>
    );
  }
}
