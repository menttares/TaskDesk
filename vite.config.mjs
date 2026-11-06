import { defineConfig } from "vite";

export default defineConfig({
  publicDir: false,

  build: {
    outDir: "wwwroot/dist",
    emptyOutDir: true,
    cssCodeSplit: false,

    rolldownOptions: {
      input: "Frontend/main.ts",

      output: {
        entryFileNames: "app.js",
        chunkFileNames: "chunks/[name]-[hash].js",

        assetFileNames: (asset) =>
          asset.names.some((name) => name.endsWith(".css"))
            ? "app.css"
            : "assets/[name]-[hash][extname]"
      }
    }
  }
});