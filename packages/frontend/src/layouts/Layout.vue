<script setup lang="ts">
import BetterIcon from '@/components/BetterIcon.vue';
import { Building2, CompassIcon, FileBadge, FileExclamationPointIcon, LayoutDashboard, ScrollText, Shield, UsersRound } from 'lucide-vue-next';

import { ref } from 'vue';

const projectName = ref("Atlas");
const ownerName = ref("rcmcodes")
const currentYear = new Date().getUTCFullYear();

</script>

<template>
  <div class="flex flex-col min-h-screen">
    <div class="navbar bg-base-100 shadow-sm">
  <div class="navbar-start">
    <div class="dropdown">
      <div tabindex="0" role="button" class="btn btn-ghost lg:hidden">
        <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" fill="none" viewBox="0 0 24 24" stroke="currentColor"> <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 6h16M4 12h8m-8 6h16" /> </svg>
      </div>
      <ul
        tabindex="-1"
        class="menu menu-sm dropdown-content bg-base-100 rounded-box z-1 mt-3 w-52 p-2 shadow">
        <li><a>
          Dashboard</a></li>
        <li>
          <a>Agency</a>
          <ul class="p-2">
            <li><a>
              
              Agents</a></li>
            <li><a>
              
              Clients</a></li>
            <li><a>Policies</a></li>
            <li><a>Claims</a></li>
            
          </ul>
        </li>
        <li><a>Products</a></li>
      </ul>
    </div>
    <a class="btn btn-ghost text-xl">
      <BetterIcon size="sm" variant="primary">
        <CompassIcon/>
      </BetterIcon>
      
      Atlas</a>
  </div>
  <div class="navbar-center hidden lg:flex">
    <ul class="menu menu-horizontal px-1">
      <li><a>
        <LayoutDashboard class="h-6 w-6"/>
        Dashboard</a></li>
      <li><a>
        <ScrollText/>
        Products</a></li>
      <li>
        <details>
          <summary>
            <Building2/>
            Agency</summary>
          <ul class="p-2">
            <li><a>
              <UsersRound/>
              Agents</a></li>
            <li><a>
              <UsersRound/>
              Clients</a></li>
            <li><a>
              <Shield/>
              Policies</a></li>
            <li><a>
              <FileExclamationPointIcon/>
              Claims</a></li>
          </ul>
        </details>
      </li>
    </ul>
  </div>
  <div class="navbar-end">
    <a class="btn">
      <FileBadge class="h-5 w-5"/>
      
      Documents</a>
  </div>
</div>
    <!-- Main Content -->
    <main class="grow">
      <slot />
    </main>

    <footer class="footer footer-horizontal footer-center bg-neutral text-neutral-content p-10">
  <aside>
    <BetterIcon size="xl" variant="secondary">
      <CompassIcon class="h-10 w-10"/>
    </BetterIcon>
    <p class="font-bold">
      {{projectName}}
      <br />
      Created by {{ownerName}}
    </p>
    <p>Copyright © {{ currentYear }} - All right reserved</p>
  </aside>
  
</footer>
  </div>
</template>