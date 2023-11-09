import React from 'react';
import Header from './components/Header';
import Footer from './components/Footer';
import Items from './components/Items';

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      items: [
        {
          id: 1,
          title: 'BMW M5 E60',
          img: 'm5e60.jpg',
          desc: 'New BMW M5 E60. V10 5.0L Motor',
          category: 'Sedan',
          price: '45.000'
        },
        {
          id: 2,
          title: 'BMW M5 F90',
          img: 'm5f90.jpg',
          desc: 'New BMW M5 F90. V8 4.4L BiTurbo Motor',
          category: 'Sedan',
          price: '90.000'
        },
        {
          id: 3,
          title: 'BMW M4',
          img: 'm4.jpg',
          desc: 'New BMW M4. V8 3.0L Motor',
          category: 'Coupe',
          price: '67.000'
        },
      ]
    }
  }

  render() {
  return (
    <>
      <div className='wrapper'>
        <Header />
        <Items items={this.state.items} />
        <Footer />
      </div>
    </>
  );
  }
}

export default App;