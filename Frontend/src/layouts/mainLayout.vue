<template>
  <q-layout view="lhh Lpr lFf">
    <q-header class="bg-primary" elevated>
      <q-toolbar
        class="row bg-primary text-white window-width q-px-none q-py-sm"
      >
        <div
          v-if="$q.platform.is.mobile"
          class="wrapper row flex justify-between col-12"
        >
          <q-icon name="img:images/studly-logo-long.svg" class="col-4" />
          <q-btn color="white" :icon="menuIcon" flat dense>
            <q-menu @before-show="openMenu" @before-hide="closeMenu">
              <q-list>
                <q-item clickable v-close-popup>
                  <q-btn flat dense label="Hjem" to="/" />
                </q-item>
                <q-separator />
                <q-item clickable v-close-popup>
                  <q-btn flat dense label="Profil" to="/Profil" />
                </q-item>
                <q-separator />
                <q-item clickable v-close-popup>
                  <q-btn flat dense label="Indberet" to="/form" />
                </q-item>
                <q-separator />
                <q-item clickable v-close-popup>
                  <q-btn flat dense label="Log ud" to="/form" />
                </q-item>
              </q-list>
            </q-menu>
          </q-btn>
        </div>
        <div
          v-if="!$q.platform.is.mobile"
          class="wrapper row flex justify-between col-xs-12"
        >
          <q-icon name="img:images/studly-logo-long.svg" class="col-md-2" />

          <div class="row col-8 flex justify-end">
            <q-btn
              class="q-ml-md"
              flat
              dense
              icon-right="mdi-account"
              label="Profil"
              to="/Profil"
            />
            <q-btn
              class="q-ml-md"
              flat
              dense
              icon-right="mdi-text-box"
              label="Indberet"
              to="/form"
            />
          </div>
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
    return {
      menuIcon: "mdi-menu"
    };
  },

  methods: {
    openMenu() {
      this.menuIcon = "mdi-menu-open";
    },
    closeMenu() {
      this.menuIcon = "mdi-menu";
    }
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
