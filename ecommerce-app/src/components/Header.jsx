import React from 'react'

function Header() {
  return (

    <header>
      <div className='header-image'>
        <div className='navigation'>
          <ul className='main-nav'>
            <li>Home</li>
            <li>Contact</li>
            <li>About</li>
            <li>Find Your BMW</li>
          </ul>
          <div className='nav-items'>
            <ul className='main-nav'>
              <li>Search</li>
              <li>Login</li>
            </ul>
          </div>
        </div>

        <div className='slogan'>
          <h1 className='main-slogan'>FIND YOUR CAR</h1>
        </div>
      </div>

    </header>
  )
}

export default Header;