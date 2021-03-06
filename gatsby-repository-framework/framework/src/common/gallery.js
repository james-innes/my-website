import React from "react";
import { useStaticQuery, graphql } from "gatsby";
import Img from "gatsby-image";

export default () => {
  const data = useStaticQuery(graphql`
    query {
      allFile(filter: { relativeDirectory: { eq: "img" } }) {
        edges {
          node {
            childImageSharp {
              fluid(maxWidth: 192, maxHeight: 144) {
                ...GatsbyImageSharpFluid
              }
            }
          }
        }
      }
    }
  `);

  return (
    <div className="gallery">
      {data.allFile.edges.map(edge => (
        <Img fluid={edge.node.childImageSharp.fluid} />
      ))}
    </div>
  );
};
