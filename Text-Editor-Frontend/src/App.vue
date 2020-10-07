<template>
  <div id="app">
    <TextEditor id="reditor" />
  </div>
</template>

<script>
import TextEditor from "./components/TextEditor.vue";

export default {
  name: "App",
  components: {
    TextEditor: TextEditor,
  },
};
</script>

<style>
body {
  background-color: darkcyan;
}
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;

  color: #2c3e50;
  margin: 60px;
}

#reditor {
  background-color: white;
}
</style>
