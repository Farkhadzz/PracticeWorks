import React from "react";

function Navbar() {
    return (
        <>
            <div className="header-top">
                <div className="container">

                    <a href="#" className="logo">
                        <img src="#" width="138" height="28" alt="EBook home" />
                    </a>

                    <div className="input-wrapper">
                        <input type="search" name="search" placeholder="Search" className="input-field" />

                        <button className="btn btn-primary">Search</button>
                    </div>
                </div>
            </div>

            <div className="header-bottom" data-navbar>
                <div className="container">

                    <nav className="navbar">

                        <button className="nav-close-btn" data-nav-toggler aria-label="clsoe menu" title="Clsoe Menu">
                            <ion-icon name="close-outline" aria-hidden="true"></ion-icon>
                        </button>

                        <div className="navbar-top">
                            <input type="search" name="search" placeholder="Search our store" className="input-field" />

                            <button className="search-btn" aria-label="Search">
                                <ion-icon name="search-outline" aria-hidden="true"></ion-icon>
                            </button>
                        </div>

                        <ul className="navbar-list">

                            <li>
                                <a href="#" className="navbar-link">Home</a>
                            </li>

                            <li>
                                <a href="#" className="navbar-link">Shop</a>
                            </li>

                            <li>
                                <a href="#" className="navbar-link">About Us</a>
                            </li>

                            <li>
                                <a href="#" className="navbar-link">Contact</a>
                            </li>

                        </ul>

                    </nav>
                </div>
            </div>
        </>
    )
}

export default Navbar;