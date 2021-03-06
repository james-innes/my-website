import React from "react";
import { Link } from "gatsby"

export default () => {
  return (
    <section>
      <nav>
        <ul>
          <li>
            <Link to="/styleguide">Styleguide</Link>
          </li>
          <li>
            <Link to="/gallery">Gallery</Link>
          </li>
          <li>
            <Link to="/movies">Movies</Link>
          </li>
        </ul>
      </nav>
    </section>
  );
};
