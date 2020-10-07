<template>
  <div>
    <Editor
      :initialValue="text"
      :options="editorOptions"
      initialEditType="wysiwyg"
      height="500px"
      @change="handleChange($event)"
      ref="toastEditor"
      :setValue="text"
    />
    <p v-html="text"></p>
  </div>
</template>

<script>
import "codemirror/lib/codemirror.css";
import { Editor } from "@toast-ui/vue-editor";
import "@toast-ui/editor/dist/toastui-editor.css";
import {
  HubConnectionBuilder,
  LogLevel,
  HttpTransportType,
} from "@microsoft/signalr";

let connection = new HubConnectionBuilder()
  .configureLogging(LogLevel.Debug)
  .withUrl("https://localhost:5001/hubs/text", {
    skipNegotiation: true,
    transport: HttpTransportType.WebSockets,
  })
  .withAutomaticReconnect()
  .build();

const defaultOptions = {
  minHeight: "200px",
  language: "en-US",
  useCommandShortcut: true,
  useDefaultHTMLSanitizer: true,
  usageStatistics: true,
  hideModeSwitch: false,
  toolbarItems: [
    "heading",
    "bold",
    "italic",
    "strike",
    "divider",
    "hr",
    "quote",
    "divider",
    "ul",
    "ol",
    "task",
    "indent",
    "outdent",
    "divider",
    "table",
    "image",
    "link",
    "divider",
    "code",
    "codeblock",
  ],
};
export default {
  name: "TextEditor",
  components: {
    Editor: Editor,
  },
  data() {
    return {
      text: "",
      editorOptions: defaultOptions,
    };
  },
  methods: {
    async handleChange() {
      let html = this.$refs.toastEditor.invoke("getHtml");
      this.text = html;
      await connection.invoke("SendText", this.text);
    },
  },
  mounted() {
    connection
      .start()
      .then(async () => {
        console.log("connected successfully !!");

        connection.on("ReceiveMessage", (data) => {
          if (this.text == data) return;
          this.text = data;

          this.$refs.toastEditor.invoke("setHtml", this.text);
        });
      })
      .catch((e) => console.log("connection failed", e));
  },
};
</script>

<style>
</style>