// const { ApolloServer } = require("apollo-server")
// const { getGatsbySchema } = require("graphql-gatsby")

// const config = undefined

// getGatsbySchema(config).then(({ schema }) => {
//   const server = new ApolloServer({ schema })
//   server.listen()
// })

const { getGatsbySchema } = require("graphql-gatsby")

getGatsbySchema().then(({ schema }) => {
  console.log(schema)
})
