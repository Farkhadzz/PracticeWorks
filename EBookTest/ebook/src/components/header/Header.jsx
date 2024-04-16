import React from "react";
import Navbar from "../navbar/Navbar";

function Header() {
    return (
        <>
            <Navbar />
            <section class="section hero has-bg-image">
                <div class="container">

                    <div class="hero-content">

                        <h1 class="h1 hero-title has-after">
                            EBOOK
                        </h1>

                        <p class="hero-text">
                            Lorem ipsum, dolor sit amet consectetur adipisicing elit. Sit quibusdam cum vitae fugit laborum, ipsam accusantium eaque ab, neque voluptatibus magni facere deleniti dolor porro corrupti eius maiores quod beatae.
                        </p>

                        <div class="btn-wrapper">

                            <a href="#" class="btn">
                                <span class="span">STORE</span>
                            </a>
                        </div>

                    </div>

                    <figure class="hero-banner">
                    <img src="head.png" width="475" height="600" alt="hero banner" class="w-100"/>
                </figure>
                </div>

        

            </section>
        </>
    )
}

export default Header;