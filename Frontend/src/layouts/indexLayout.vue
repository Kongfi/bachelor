<template>
  <q-layout view="lhh Lpr lFf">
    <q-header class="bg-primary" elevated>
      <q-toolbar
        class="row bg-primary text-white window-width q-px-none q-py-sm"
      >
        <div class="wrapper row flex justify-between col-12">
          <q-icon
            name="img:images/studly-logo-long.svg"
            class="col-5 col-md-2"
          />
        </div>
      </q-toolbar>
    </q-header>
    <q-page-container class="flex fit bg-indigo-1">
      <router-view class="wrapper" />
    </q-page-container>
    <q-footer class="wrapper"></q-footer>
  </q-layout>
</template>

<script>
export default {
  name: "MainLayout",
  data() {
    return {};
  }
};
</script>

<style lang="scss" scoped>
.wrapper {
  width: 90%;
  margin: 0 auto;

  @media (min-width: $breakpoint-sm-min) {
    width: 480px;
  }
  @media (min-width: $breakpoint-md-min) {
    width: 640px;
  }
  @media (min-width: $breakpoint-lg-min) {
    width: 720px;
  }
  @media (min-width: $breakpoint-xl-min) {
    width: 1280px;
  }
}
</style>
