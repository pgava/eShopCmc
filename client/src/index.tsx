import React from 'react';
import { createRoot } from 'react-dom/client';
import { App } from './App';
import './App.scss'

const root = createRoot(
  document.getElementById('root') as HTMLElement
);

root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);
