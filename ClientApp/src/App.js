import React, { Component } from 'react';
import { Route } from 'react-router';

import SectorMap from './components/SectorMap';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <SectorMap></SectorMap>
    );
  }
}
